using System.Collections.Generic;

namespace LeetChallengeMay.May29CourseSchedule
{
    public class CourseScheduleSolution
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            Dictionary<int, List<int>> courseDependencyMapping = new Dictionary<int, List<int>>();
            int[] indegree = new int[numCourses];
            Queue<int> queue = new Queue<int>();
            int count = 0;
            for (int i = 0; i < numCourses; i++)
            {
                courseDependencyMapping.Add(i, new List<int>());
            }
            for (int i = 0; i < prerequisites.Length; i++)
            {
                var dependency = courseDependencyMapping[prerequisites[i][0]];
                dependency.Add(prerequisites[i][1]);
                indegree[prerequisites[i][1]]++;
            }
            for (int i = 0; i < numCourses; i++)
            {
                if (indegree[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }
            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                var dependencies = courseDependencyMapping[current];
                foreach (var dependency in dependencies)
                {
                    if (--indegree[dependency] == 0)
                    {
                        queue.Enqueue(dependency);
                    }
                }
                count++;
            }
            return count == numCourses;
        }
    }
}